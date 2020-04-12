import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home/home.component';
import { TopComponent } from './top/top.component';
import { SharedModule } from '../shared/shared.module';
import { NzLayoutModule, NzGridModule } from 'ng-zorro-antd';
import { NzCardModule } from 'ng-zorro-antd/card';



@NgModule({
  declarations: [HomeComponent, TopComponent],
  imports: [
    CommonModule,
    SharedModule,
    NzLayoutModule,
    NzGridModule,
    NzCardModule
  ]
})
export class HomeModule { }
