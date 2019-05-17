import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-new-place',
  templateUrl: './locations.component.html'
})
export class LocationsComponent {
  locations: PlaceLocation[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    debugger;
    http.get<PlaceLocation[]>(baseUrl + 'api/Location/GetLocations').subscribe(result => {
      debugger;
      this.locations = result;
    });
  }
}


class PlaceLocation {
  Id: string; //Guid?
  Name: string;
  Address1: string;
  Address2: string;
  Address3: string;
  PostCode: string;
}
