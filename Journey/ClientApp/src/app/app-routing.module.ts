import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { DestinationModule } from './destination/destination.module';
import { DestinationComponent } from './destination/destination/destination.component';
import { HomeModule } from './home/home.module';
import { HomeComponent } from './home/home/home.component';

const routes: Routes =[
  { path: '', redirectTo: '/home', pathMatch: 'full'},
  {path: 'destination', component: DestinationComponent},
  {path: 'home', component: HomeComponent}
]

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    DestinationModule,
    HomeModule,
    RouterModule.forRoot(routes)
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
