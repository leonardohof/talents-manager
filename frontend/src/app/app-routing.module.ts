import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { TalentsComponent } from './pages/talents/talents.component';
import { TalentsCreateEditComponent } from './pages/talents-create-edit/talents-create-edit.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'talents', component: TalentsComponent },
  { path: 'talents/create', component: TalentsCreateEditComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
