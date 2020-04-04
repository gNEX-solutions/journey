import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavBarComponent } from './components/nav-bar/nav-bar.component';
import {MatToolbarModule} from '@angular/material';


@NgModule({
  declarations: [NavBarComponent],
  imports: [
    CommonModule,
    MatToolbarModule
  ],
  exports: [NavBarComponent]
})
export class SharedModule { }
