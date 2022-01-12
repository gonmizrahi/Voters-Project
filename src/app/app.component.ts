import { Component } from '@angular/core';
import partylist from './_files/partylist.json';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'VotersPojectAngular';

  partyList:{name:string, description:string}[]= partylist;
}
