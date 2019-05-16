import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-new-place',
  templateUrl: './locations.component.html'
})
export class LocationsComponent {
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    //just empty for now...
  }
}
