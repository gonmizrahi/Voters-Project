import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SystemAnalystComponent } from './system-analyst/system-analyst.component';
import { VoterListComponent } from './voter-list/voter-list.component';
import { VotingComponent } from './voting/voting.component';


const routes: Routes = [

  { path: 'voters', component:VoterListComponent ,pathMatch: 'full'},
  { path: 'voting', component: VotingComponent },
  { path: 'system', component: SystemAnalystComponent },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
