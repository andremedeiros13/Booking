import { Component, Inject } from '@angular/core';
import {
  MAT_DIALOG_DATA,
  MatDialog,
  MatDialogModule,
} from '@angular/material/dialog';
import { BookingService } from '../../services/booking.service';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { CommonModule } from '@angular/common';
import { MatFormFieldModule } from '@angular/material/form-field';
import {
  FormBuilder,
  FormGroup,
  FormsModule,
  Validators,
} from '@angular/forms';
import {MatIconModule} from '@angular/material/icon';

@Component({
  selector: 'app-edit',
  standalone: true,
  imports: [
    CommonModule,
    MatDialogModule,
    MatProgressSpinnerModule,
    MatFormFieldModule,
    FormsModule,
    MatIconModule
  ],
  providers: [BookingService],
  templateUrl: './edit.component.html',
  styleUrl: './edit.component.scss',
})
export class EditComponent {
  bookingForm: FormGroup;

  constructor(
    @Inject(MAT_DIALOG_DATA) public booking: any,
    private bookingService: BookingService,
    public dialog: MatDialog,
    private formBuilder: FormBuilder
  ) {
    this.bookingForm = this.formBuilder.group({
      startDate: [this.booking.startDate, Validators.required],
      endDate: [this.booking.endDate, Validators.required],
      customerName: [this.booking.customer.name, Validators.required],
      vehicleModel: [this.booking.vehicle.model, Validators.required],
    });
  }

  ngOnInit() {
    this.bookingForm = this.formBuilder.group({
      startDate: [this.booking.startDate, Validators.required],
      endDate: [this.booking.endDate, Validators.required],
      customerName: [this.booking.customer.name, Validators.required],
      vehicleModel: [this.booking.vehicle.model, Validators.required],
    });
  }
}
