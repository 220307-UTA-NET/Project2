import { HttpClient, HttpParams } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  
  
  Password : string = '';
  userlist : any;
  
  
  pet_name= " PET SITTER ";
  constructor(private route : ActivatedRoute ,private formBuilder : FormBuilder, private http : HttpClient, private router :Router) {this.userlist =[]; }

  ngOnInit(): void {
    
  }
      findcustomer(event: string){
      console.log(event);
      var params = new HttpParams().set("keyword", event);
      this.http.get('https://petservice.azurewebsites.net/api/User_login/User?Id='+ event).subscribe(
      
      ( data: any ) =>{ 
        
        
        console.log(data);
        if (data.user_Id == event){this.router.navigate(['homepage']);}
      }
                    
      )


    }

}


 




