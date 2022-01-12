import { Injectable } from '@angular/core';
import  {HttpClient} from '@angular/common/http'
@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http:HttpClient) { }
  getData (){
    let url = "http://localhost:49924/api/cars/getcars";
    
    return this.http.get(url);
}}
