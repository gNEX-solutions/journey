import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShortDescriptionComponent } from './short-description/short-description.component';
import { DestinationComponent } from './destination/destination.component';
import { SharedModule } from '../shared/shared.module';



@NgModule({
  declarations: [ShortDescriptionComponent, DestinationComponent],
  imports: [
    CommonModule,
    SharedModule
  ],
  exports: [ShortDescriptionComponent]
})
export class DestinationModule { }
