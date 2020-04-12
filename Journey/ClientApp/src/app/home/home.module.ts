import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home/home.component';
import { TopComponent } from './top/top.component';
import { SharedModule } from '../shared/shared.module';



@NgModule({
  declarations: [HomeComponent, TopComponent],
  imports: [
    CommonModule,
    SharedModule,
  ]
})
export class HomeModule { }
