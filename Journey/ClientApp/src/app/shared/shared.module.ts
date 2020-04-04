import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavBarComponent } from './components/nav-bar/nav-bar.component';
import {MatToolbarModule, MatFormFieldModule, MatSelectModule, MatInputModule, MatIconModule, MatButtonModule, MatCardModule} from '@angular/material';
import { MatGridListModule } from '@angular/material';


@NgModule({
  declarations: [NavBarComponent],
  imports: [
    CommonModule,
    MatToolbarModule,
    MatGridListModule,
    MatFormFieldModule,
    MatSelectModule,
    MatInputModule,
    MatIconModule,
    MatButtonModule,
    MatCardModule
  ],
  exports: [NavBarComponent]
})
export class SharedModule { }
