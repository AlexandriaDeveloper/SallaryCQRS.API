import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RouterModule } from '@angular/router';
import { MaterialModule } from './material/material.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavbarComponent } from './components/navbar/navbar.component';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';
import { TableSearchBoxComponent } from './components/table-search-box/table-search-box.component';



@NgModule({
  declarations: [
    NavbarComponent,
    TableSearchBoxComponent
  ],
  imports: [
    CommonModule,
    RouterModule,

    MaterialModule

  ],
  exports:[MaterialModule,
    NavbarComponent,
    TableSearchBoxComponent,

  ]
})
export class SharedModule { }
