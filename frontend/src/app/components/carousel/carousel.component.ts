import { ChangeDetectionStrategy, Component } from '@angular/core';

interface CarouselItem {
  id: string;
  description: string;
  image: string;
  index?: number;
}

@Component({
  selector: 'app-carousel',
  standalone: false,
  templateUrl: './carousel.component.html',
  styleUrl: './carousel.component.css',
})
export class CarouselComponent {
  items: CarouselItem[] = [
    {
      id: '1',
      description: 'Image 1',
      image: 'https://placehold.co/600x400',
    },
    {
      id: '2',
      description: 'Image 2',
      image: 'https://placehold.co/600x500',
    },
    {
      id: '3',
      description: 'Image 3',
      image: 'https://placehold.co/600x600',
    },
  ].map((item, index) => ({
    ...item,
    index,
  }));

  currentIndex = 0;

  constructor() {}

  next() {
    this.currentIndex = (this.currentIndex + 1) % this.items.length;
  }

  prev() {
    this.currentIndex =
      (this.currentIndex - 1 + this.items.length) % this.items.length;
  }

  goTo(index: number) {
    this.currentIndex = index;
  }
}
