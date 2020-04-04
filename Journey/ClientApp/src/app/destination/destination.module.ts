import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShortDescriptionComponent } from './short-description/short-description.component';
import { DestinationComponent } from './destination/destination.component';
import { SharedModule } from '../shared/shared.module';
import { MatGridListModule } from '@angular/material';



@NgModule({
  declarations: [ShortDescriptionComponent, DestinationComponent],
  imports: [
    CommonModule,
    SharedModule,
    MatGridListModule
  ],
  exports: [ShortDescriptionComponent]
})
export class DestinationModule { }
