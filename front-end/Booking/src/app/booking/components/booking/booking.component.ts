import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { MatTableModule } from '@angular/material/table';
import { MatCardModule } from '@angular/material/card';
import { MatToolbarModule } from '@angular/material/toolbar';
import { HttpClientModule } from '@angular/common/http';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatIconModule } from '@angular/material/icon';
import { Observable, switchMap } from 'rxjs';
import { Bookings } from '../../models/booking';
import { BookingService } from '../../services/booking.service';
import { MatButtonModule } from '@angular/material/button';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { SelectionModel } from '@angular/cdk/collections';
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { EditComponent } from '../edit/edit.component';

@Component({
  selector: 'app-booking',
  standalone: true,
  imports: [
    CommonModule,
    MatTableModule,
    MatCardModule,
    MatToolbarModule,
    HttpClientModule,
    MatProgressSpinnerModule,
    MatIconModule,
    MatButtonModule,
    MatCheckboxModule,
    MatDialogModule,
    EditComponent,
  ],
  providers: [BookingService],
  templateUrl: './booking.component.html',
  styleUrl: './booking.component.scss',
})
export class BookingComponent {
  displayedColumns = [
    'select',
    'bookingId',
    'startDate',
    'endDate',
    'name',
    'model',
    'edit',
  ];
  bookings$: Observable<Bookings[]>;
  bookingsEdit: any;
  selection = new SelectionModel<Bookings>(true, []);
  bookingId: any;
  totalRows = 0;

  constructor(
    private bookingService: BookingService,
    public dialog: MatDialog
  ) {
    this.bookings$ = this.bookingService.list();
    this.bookings$.subscribe((bookings) => {
      this.totalRows = bookings.length;
    });
  }

  isAllSelected() {
    const numSelected = this.selection.selected.length;
    const numRows = this.totalRows;
    return numSelected === numRows;
  }

  toggleAllRows() {
    if (this.isAllSelected()) {
      this.selection.clear();
    } else {
      this.bookings$.subscribe((bookings) => {
        bookings.forEach((row) => this.selection.select(row));
      });
    }
  }

  checkboxLabel(row?: Bookings): string {
    if (!row) {
      return `${this.isAllSelected() ? 'deselect' : 'select'} all`;
    }
    return `${this.selection.isSelected(row) ? 'selected' : 'deselected'} row ${
      row.bookingId + 1
    }`;
  }

  // editBooking(booking: Bookings) {
  //   this.bookingService.edit(booking.bookingId).subscribe({
  //     next: (response) => (this.bookingsEdit = response),
  //     error: (err) => console.error(err),
  //   });
  //   const dialogRef = this.dialog.open(EditComponent, {
  //     data: this.bookingsEdit,
  //   });

  //   dialogRef.afterClosed().subscribe((result) => {
  //     console.log(`Dialog result: ${result}`);
  //   });
  // }

  editBooking(booking: Bookings) {
    this.bookingService.edit(booking.bookingId).subscribe({
      next: (response) => {
        this.bookingsEdit = response; // Armazena o valor de resposta em this.bookingsEdit
        const dialogRef = this.dialog.open(EditComponent, {
          data: this.bookingsEdit, // Passa this.bookingsEdit como parte do objeto data
        });

        dialogRef.afterClosed().subscribe((result) => {
          console.log(`Dialog result: ${result}`);
        });
      },
      error: (err) => console.error(err),
    });
  }
}
