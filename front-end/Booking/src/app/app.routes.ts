import { Routes } from '@angular/router';
import { BookingComponent } from './booking/components/booking/booking.component';

export const routes: Routes = [
  {path: '', pathMatch: 'full', redirectTo: 'bookings'},
  {path: 'bookings', component: BookingComponent}
];
