import { HttpClient, HttpParams } from '@angular/common/http';
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
  public user_Name ! : string;
  public user_FirstName ! : string;
  public user_LastName ! :string;
  public user_Password !: string;
  public user_Id !: null;
  

  constructor(private formBuilder : FormBuilder, private http : HttpClient, private router :Router) { }

  ngOnInit(): void {}
  registercustomers1(){
    const User_input = { 
      
      user_Name:this.user_Name,
      user_FirstName:this.user_FirstName,
      user_LastName:this.user_LastName,
      user_Password:this.user_Password}
    console.log(User_input)
    this.http.post<any>("https://petservice.azurewebsites.net/api/User_login/register", User_input).subscribe (res=>{
                     alert("signup successfull");
                     this.router.navigate(['login']);
  
  },err=>{alert ("something went wrong")});
  
  
  }

 
 
  

}
