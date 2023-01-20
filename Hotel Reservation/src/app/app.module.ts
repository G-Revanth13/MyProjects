import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { ListComponent } from './list/list.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatCardModule} from '@angular/material/card';
import{ MatTable, MatTableModule } from '@angular/material/table'
import { HttpClientModule } from '@angular/common/http';
import {MatButtonModule} from '@angular/material/button';
import {MatDialogModule} from '@angular/material/dialog';
import { DialogComponent } from './dialog/dialog.component';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatInputModule} from '@angular/material/input';
import {MatSelectModule} from '@angular/material/select';
import {MatDatepickerModule} from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';
import {MatPaginatorModule} from '@angular/material/paginator';
import {MatSort} from '@angular/material/sort';
import { DeleteComponent } from './delete/delete.component';
import {MatToolbarModule} from '@angular/material/toolbar';






@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    ListComponent,
    DialogComponent,
    DeleteComponent,
  ],
  imports: [
    BrowserModule,ReactiveFormsModule,
    AppRoutingModule,FormsModule, BrowserAnimationsModule,
    MatCardModule,MatTableModule,HttpClientModule,
    MatButtonModule,MatDialogModule,MatFormFieldModule,MatInputModule,MatSelectModule,
    MatDatepickerModule,MatNativeDateModule,MatPaginatorModule,MatToolbarModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
