import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DataService } from './dataservice.component';
import { ActivatedRoute } from '@angular/router';

//View all locations
@Component({
  selector: 'show-locations-screen',
  templateUrl: './locations.component.html'
})
export class LocationManagementComponent {
  locations: Location[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Location[]>(baseUrl + 'api/Location/GetLocations').subscribe(result => {
      this.locations = result;
    });
  }
}

//Edit/Create location
@Component({
  selector: 'app-new-location',
  templateUrl: './newlocation.component.html',
})
export class LocationComponent {
  router: ActivatedRoute;

  client: HttpClient;
  baseUrl: string;
  location: Location = new Location();

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, private route: ActivatedRoute) {
    //just empty for now...
    this.client = http;
    this.router = route;
    this.baseUrl = baseUrl;

    var locationId = route.snapshot.paramMap.get("id");

    if (locationId) {
      this.client.get<Location>(this.baseUrl + 'api/Location/GetLocation?id=' + locationId).subscribe(result => {
        this.location = result;
      }, error => console.error(error));
    }
  }

  submitForm() {
    this.client.post(this.baseUrl + 'api/Location/NewLocation', this.location).subscribe(result => {
    }, error => console.error(error));
  };
}

class Location {
  id: string; //Guid?
  name: string;
  address1: string;
  address2: string;
  address3: string;
  postCode: string;
}
