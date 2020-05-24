import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShortDescriptionComponent } from './short-description/short-description.component';
import { DestinationComponent } from './destination/destination.component';
import { SharedModule } from '../shared/shared.module';
import { NzLayoutModule } from 'ng-zorro-antd/layout';
import { NzGridModule } from 'ng-zorro-antd/grid';



@NgModule({
  declarations: [ShortDescriptionComponent, DestinationComponent],
  imports: [
    CommonModule,
    SharedModule,
    NzLayoutModule,
    NzGridModule
  ],
  exports: [ShortDescriptionComponent]
})
export class DestinationModule { }
