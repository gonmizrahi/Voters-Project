import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { VoterListComponent } from './voter-list/voter-list.component';
import { VotingComponent } from './voting/voting.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { DatePipe } from '@angular/common';
import { SystemAnalystComponent } from './system-analyst/system-analyst.component';


@NgModule({
  declarations: [
    AppComponent,
    VoterListComponent,
    VotingComponent,
    SystemAnalystComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,HttpClientModule,FormsModule,
  ],
  providers: [DatePipe],
  bootstrap: [AppComponent]
})
export class AppModule { }
