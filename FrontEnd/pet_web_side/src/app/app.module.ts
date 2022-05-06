// import { NgModule } from '@angular/core';
// import { BrowserModule } from '@angular/platform-browser';


import { HttpClientModule } from "@angular/common/http";
import { AppComponent } from './app.component';
import { PetImagesComponent } from './pet-images/pet-images.component';
import { AppRoutingModule } from './app-routing.module';
import { RegisterCustomerComponent } from './register-customer/register-customer.component';
import { LoginComponent } from './login/login.component';
import { BrowserModule } from "@angular/platform-browser";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { NgModule } from "@angular/core";

@NgModule({
  declarations: [
    AppComponent,
    PetImagesComponent,
    RegisterCustomerComponent,
    LoginComponent,
  ],
  
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    ReactiveFormsModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})

export class AppModule {

}

