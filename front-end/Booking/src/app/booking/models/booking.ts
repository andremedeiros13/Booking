export interface Booking {
  data: Bookings[];
  succeeded: boolean;
  error: string | null;
}

export interface Bookings {
  bookingId: number;
  startDate: string;
  endDate: string;
  customerId: number;
  vehicleId: number;
  ratingStatus: boolean;
  commentStatus: boolean;
  vehicle: Vehicle | null;
  customer: Customer;
}

export interface Vehicle {
  vehicleId: number;
  model: string;
}

export interface Customer {
  customerId: number;
  name: string;
}
