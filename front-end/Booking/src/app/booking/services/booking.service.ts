import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Booking } from '../models/booking';
import { map, take } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class BookingService {
  private readonly API = 'https://localhost:44308/api/Booking';
  constructor(private http: HttpClient) {}

  list() {
    return this.http.get<Booking>(this.API).pipe(
      take(1),
      map((response: Booking) => response.data)
    );
  }

  edit(id: any) {
    return this.http.get<Booking>(`${this.API}/${id}`).pipe(
      take(1),
      map((response: Booking) => response.data)
    );
  }
}
