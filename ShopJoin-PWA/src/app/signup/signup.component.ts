import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.scss']
})
export class SignupComponent implements OnInit {
  model: any = {};
  constructor() { }

  ngOnInit() {
  }

  register(){
    console.log(this.model);
  }

  cancel(){
    console.log('cancelled');
  }
}
