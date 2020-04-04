import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { DestinationModule } from './destination/destination.module';
import { DestinationComponent } from './destination/destination/destination.component';

const routes: Routes =[
  { path: '', redirectTo: '/destination', pathMatch: 'full'},
  {path: 'destination', component: DestinationComponent}
]

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    DestinationModule,
    RouterModule.forRoot(routes)
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
