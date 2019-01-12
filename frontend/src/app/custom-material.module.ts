import { NgModule } from "@angular/core";
import {
  MatButtonModule,
  MatCheckboxModule,
  MatIconModule,
  MatMenuModule,
  MatToolbarModule,
  MatTableModule,
  MatCardModule,
  MatInputModule,
  MatFormFieldModule,
  MatTabsModule,
  MatRadioModule,
  MatDialogModule,
  MatStepperModule
} from "@angular/material";

@NgModule({
  imports: [
    MatButtonModule,
    MatCheckboxModule,
    MatIconModule,
    MatMenuModule,
    MatToolbarModule,
    MatTableModule,
    MatCardModule,
    MatInputModule,
    MatFormFieldModule,
    MatTabsModule,
    MatRadioModule,
    MatDialogModule,
    MatStepperModule
  ],
  exports: [
    MatButtonModule,
    MatCheckboxModule,
    MatIconModule,
    MatMenuModule,
    MatToolbarModule,
    MatTableModule,
    MatCardModule,
    MatInputModule,
    MatFormFieldModule,
    MatTabsModule,
    MatRadioModule,
    MatDialogModule,
    MatStepperModule
  ]
})
export class CustomMaterialModule {}
