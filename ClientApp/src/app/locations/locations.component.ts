import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DataService } from './dataservice.component';

@Component({
  selector: 'show-locations-screen',
  templateUrl: './locations.component.html'
})
export class LocationsComponent implements OnInit {
  locations: Location[];

  constructor(private data: DataService, http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Location[]>(baseUrl + 'api/Location/GetLocations').subscribe(result => {
      this.locations = result;
    });
  }

  ngOnInit() {
    this.data.changeMessage("this is a test of message");
  }
}

@Component({
  selector: 'app-new-location',
  templateUrl: './newlocation.component.html',
})
export class NewLocationComponent implements OnInit {
  client: HttpClient;
  baseUrl: string;
  stuff: string = "";

  ngOnInit() {
    this.data.currentMessage.subscribe(x => this.stuff = x);
  }

  constructor(private data: DataService, http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    //just empty for now...
    this.client = http;
    this.baseUrl = baseUrl;

    data.currentMessage.subscribe(message => this.stuff = message);
  }

  //Form bindings
  name: string;
  addressLine1: string;
  addressLine2: string;
  addressLine3: string;
  postCode: string;

  submitForm() {
    var location = new Location();

    location.Name = this.name;
    location.Address1 = this.addressLine1;
    location.Address2 = this.addressLine2;
    location.Address3 = this.addressLine3;
    location.PostCode = this.postCode;

    this.client.post(this.baseUrl + 'api/Location/NewLocation', location).subscribe(result => {
    }, error => console.error(error));
  };
}

class Location {
  Id: string; //Guid?
  Name: string;
  Address1: string;
  Address2: string;
  Address3: string;
  PostCode: string;
}
