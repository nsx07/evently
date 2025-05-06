import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { provideHttpClient } from '@angular/common/http';
import { BrowserModule } from '@angular/platform-browser';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';

import { AppRouter } from './app-router.component';
import { ApiService } from './services/api.service';
import { AppRoutingModule } from './app-routing.module';

import { LandingComponent } from './pages/landing/landing.component';
import { CarouselComponent } from './components/carousel/carousel.component';
import { EventComponent } from './pages/event/event.component';

@NgModule({
  declarations: [
    AppRouter,
    LandingComponent,
    CarouselComponent,
    EventComponent,
  ],
  imports: [BrowserModule, AppRoutingModule, ReactiveFormsModule],
  providers: [provideAnimationsAsync(), provideHttpClient(), ApiService],
  bootstrap: [AppRouter],
})
export class AppModule {}
