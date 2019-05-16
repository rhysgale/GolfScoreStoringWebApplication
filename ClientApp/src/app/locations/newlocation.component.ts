import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-new-location',
  templateUrl: './newlocation.component.html'
})
export class NewLocationComponent {
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    //just empty for now...
  }
}
