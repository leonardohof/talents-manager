import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { TalentsComponent } from './pages/talents/talents.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'talents', component: TalentsComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
