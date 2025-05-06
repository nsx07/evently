import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { EventDto } from '../../types/event/event';
import { ApiService } from '../../services/api.service';
import { ActivatedRoute } from '@angular/router';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-event',
  standalone: false,
  templateUrl: './event.component.html',
  styleUrl: './event.component.css',
})
export class EventComponent implements OnInit {
  public id: string | null = null;
  public event: EventDto | null = null;
  public form!: FormGroup;
  public errorMessage: string | null = null;

  constructor(
    private readonly api: ApiService,
    private readonly activatedRoute: ActivatedRoute,
    private readonly fb: FormBuilder
  ) {
    this.createForm();
  }

  ngOnInit(): void {
    this.getData();
  }

  async onSubmit() {
    if (this.form.valid) {
      const formData = this.form.value;
      console.log('Form submitted:', formData);
      const command: Omit<EventDto, 'id'> = {
        title: formData.title,
        description: formData.description,
        startDate: formData.startDate,
        endDate: formData.endDate,
        location: formData.location,
      };

      try {
        const result = await this.api.post<{ data: string }>('event', command);
        console.log(result);
        console.log('Event saved successfully');
        this.event = { ...command, id: result.data };
      } catch (error) {
        console.error('Error saving event:', error);
        this.errorMessage = 'Error saving event';
      }
    } else {
      console.log('Form is invalid');
    }
  }

  private createForm() {
    this.form = this.fb.group({
      title: [''],
      description: [''],
      startDate: [''],
      endDate: [''],
      location: [''],
    });
  }

  private async getData() {
    this.id = this.activatedRoute.snapshot.paramMap.get('id');

    if (this.id) {
      try {
        this.event = await this.api.get<EventDto>(`event/${this.id}`);
      } catch (error) {
        console.error('Error fetching event:', error);
      }
    }
  }
}
