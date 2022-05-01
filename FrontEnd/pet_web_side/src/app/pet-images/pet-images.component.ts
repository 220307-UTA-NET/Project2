import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pet-images',
  templateUrl: './pet-images.component.html',
  styleUrls: ['./pet-images.component.css']
})
export class PetImagesComponent implements OnInit {
  

  pet_name= "pluto";
  constructor() { }

  ngOnInit(): void {
  }
  onFileSelected(event: any){ 
    console.log(event);}

}
