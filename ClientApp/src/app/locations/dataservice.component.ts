import { Injectable } from "@angular/core";
import { BehaviorSubject } from "rxjs";


@Injectable({
  providedIn: 'root'
})
export class DataService {

  private currentEditId = new BehaviorSubject("");

  id = this.currentEditId.asObservable();
}
