import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home/home.component';
import { TopComponent } from './top/top.component';
import { SharedModule } from '../shared/shared.module';
import { MatGridListModule, MatDividerModule, MatCardModule } from '@angular/material';



@NgModule({
  declarations: [HomeComponent, TopComponent],
  imports: [
    CommonModule,
    SharedModule,
    MatGridListModule,
    MatDividerModule,
    MatCardModule
  ]
})
export class HomeModule { }
