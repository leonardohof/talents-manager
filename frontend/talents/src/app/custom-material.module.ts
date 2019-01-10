import { NgModule } from '@angular/core';
import { MatButtonModule, MatCheckboxModule, MatIconModule, MatMenuModule, MatToolbarModule, MatTableModule, MatCardModule } from '@angular/material';

@NgModule({
  imports: [MatButtonModule, MatCheckboxModule, MatIconModule, MatMenuModule, MatToolbarModule, MatTableModule, MatCardModule],
  exports: [MatButtonModule, MatCheckboxModule, MatIconModule, MatMenuModule, MatToolbarModule, MatTableModule, MatCardModule],
})
export class CustomMaterialModule { }
