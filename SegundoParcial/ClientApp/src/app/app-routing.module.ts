import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SearchComponent } from '../app/covid/search/search.component';
import { RecordComponent } from '../app/covid/record/record.component';
import { DonateComponent } from '../app/covid/donate/donate.component';

import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: 'record',
    component: RecordComponent
  },
  {
    path: 'search',
    component: SearchComponent
  },
  { 
    path: '', 
    component: RecordComponent
  },
  { 
    path: 'donate', 
    component: DonateComponent
  }
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  exports:[RouterModule]
})
export class AppRoutingModule { }
