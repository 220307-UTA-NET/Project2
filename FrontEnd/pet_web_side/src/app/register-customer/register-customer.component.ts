import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register-customer',
  templateUrl: './register-customer.component.html',
  styleUrls: ['./register-customer.component.css' ]
})
export class RegisterCustomerComponent implements OnInit {

  public registercustomer !: FormGroup;

  constructor(private formBuilder : FormBuilder, private http : HttpClient, private router :Router) { }

  ngOnInit(): void {
    this.registercustomer= this.formBuilder.group({
      
      user_Name:[''],
      user_FirstName:[''],
      user_LastName:[''],
      user_Password:[''],
      

    })

  }
  registercustomers1(){
    this.http.post<any>("https://petservice.azurewebsites.net/create_user", this.registercustomer.value).subscribe (res=>{
                     alert("signup successfull");
                     this.registercustomer.reset();
                     this.router.navigate(['login']);
  
  },err=>{alert ("something went wrong")});
  
    
  }

}
