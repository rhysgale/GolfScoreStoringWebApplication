import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-new-game',
  templateUrl: './newgame.component.html'
})
export class NewGameComponent {
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    //just empty for now...
  }
}
