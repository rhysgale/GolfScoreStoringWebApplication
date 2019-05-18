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
  client: HttpClient;
  baseUrl: string;
  location: Location = new Location();

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, private route: ActivatedRoute) {
    //just empty for now...
    this.client = http;
    this.baseUrl = baseUrl;

    var locationId = route.snapshot.paramMap.get("id");

    if (locationId) {
      this.client.get<Location>(this.baseUrl + 'api/Location/GetLocation?id=' + locationId).subscribe(result => {
        this.name = result.name;
        this.addressLine1 = result.address1;
        this.addressLine2 = result.address2;
        this.addressLine3 = result.address3;
        this.postCode = result.postCode;
      }, error => console.error(error));
    }
  }

  submitForm() {
    var location = new Location();

    location.name = this.name;
    location.address1 = this.addressLine1;
    location.address2 = this.addressLine2;
    location.address3 = this.addressLine3;
    location.postCode = this.postCode;

    this.client.post(this.baseUrl + 'api/Location/NewLocation', location).subscribe(result => {
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
