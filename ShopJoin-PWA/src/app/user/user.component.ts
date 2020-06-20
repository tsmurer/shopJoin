import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.scss']
})
export class UserComponent implements OnInit {
  users: any;

  constructor(private http: HttpClient) { } // importar também HttpClientModule no app.module.ts

  ngOnInit() {
    this.getUsers();
  }

  getUsers() {
    this.http.get('http://localhost:5000/User').subscribe(response => {
      this.users = response;
    }, error => {
      console.log(error);
    });
  }

}
