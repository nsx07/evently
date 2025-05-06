import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { ApiService } from '../../services/api.service';
import { EventDto } from '../../types/event/event';

@Component({
  standalone: false,
  selector: 'app-landing',
  templateUrl: './landing.component.html',
  styleUrl: './landing.component.css',
})
export class LandingComponent implements OnInit {
  public events: EventDto[] = [];

  constructor(private readonly api: ApiService) {}

  ngOnInit(): void {
    this.getData();
  }

  private async getData() {
    try {
      this.events = await this.api
        .get<{ data: EventDto[] }>('event')
        .then((res) => res.data);
    } catch (error) {
      console.error('Error fetching events:', error);
    }
  }

  register(event: string) {
    console.log('Registering for event:', event);
  }
}
