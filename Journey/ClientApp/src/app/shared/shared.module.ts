import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavBarComponent } from './components/nav-bar/nav-bar.component';
import { NzGridModule } from 'ng-zorro-antd/grid';
import { NzSelectModule } from 'ng-zorro-antd/select';
import { NzInputModule } from 'ng-zorro-antd/input';
import { NzButtonModule } from 'ng-zorro-antd/button';
import { NzIconModule } from 'ng-zorro-antd';



@NgModule({
  declarations: [NavBarComponent],
  imports: [
    CommonModule,
    NzGridModule,
    NzSelectModule,
    NzInputModule,
    NzButtonModule,
    NzIconModule
  ],
  exports: [NavBarComponent]
})
export class SharedModule { }
