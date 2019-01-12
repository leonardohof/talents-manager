import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FlexLayoutModule } from "@angular/flex-layout";
import { NgSelectModule } from '@ng-select/ng-select';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './pages/home/home.component';
import { CustomMaterialModule } from './custom-material.module';
import { TalentsComponent } from './pages/talents/talents.component';
import { AppHeaderComponent } from './app-header/app-header.component';
import { TalentsCreateEditComponent } from './pages/talents-create-edit/talents-create-edit.component';
import { TalentsService } from './services/talents.service';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DeleteConfirmDialogComponent } from './shared/delete-confirm-dialog/delete-confirm-dialog.component';
import { Configuration } from './app.constants';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    TalentsComponent,
    AppHeaderComponent,
    TalentsCreateEditComponent,
    DeleteConfirmDialogComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    CustomMaterialModule,
    FlexLayoutModule,
    FormsModule,
    ReactiveFormsModule,
    NgSelectModule,
    HttpClientModule
  ],
  providers: [Configuration, TalentsService],
  bootstrap: [AppComponent],
  entryComponents:[
    DeleteConfirmDialogComponent
  ]
})
export class AppModule { }
