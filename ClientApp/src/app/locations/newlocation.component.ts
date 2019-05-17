import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-new-location',
  templateUrl: './newlocation.component.html'
})
export class NewLocationComponent {
  client: HttpClient;
  baseUrl: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    //just empty for now...
    this.client = http;
    this.baseUrl = baseUrl;
  }

  //Form bindings
  name: string;
  addressLine1: string;
  addressLine2: string;
  addressLine3: string;
  postCode: string;

  submitForm() {
    debugger;
    var location = new NewLocation();

    location.Name = this.name;
    location.Address1 = this.addressLine1;
    location.Address2 = this.addressLine2;
    location.Address3 = this.addressLine3;
    location.PostCode = this.postCode;

    this.client.post(this.baseUrl + 'api/Location/NewLocation', location).subscribe(result => {
    }, error => console.error(error));
  };
}

class NewLocation {
  Name: string;
  Address1: string;
  Address2: string;
  Address3: string;
  PostCode: string;
}
