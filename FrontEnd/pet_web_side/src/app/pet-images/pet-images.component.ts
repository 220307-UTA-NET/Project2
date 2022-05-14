import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-pet-images',
  templateUrl: './pet-images.component.html',
  styleUrls: ['./pet-images.component.css']
})
export class PetImagesComponent implements OnInit {
  

  postedFile!: File ;
  pet_name= "Welcome Dear Customers";
  
  constructor( private http: HttpClient) { }


  ngOnInit(): void {
  }
  onFileSelected(event: any) 
  { 
    this.postedFile=<File>event.target.files[0]; 
   
  }
  onUpload(){
    const Form_Data = new FormData();
    Form_Data.append('postedFile', this.postedFile,this.postedFile.name);
    this.http.post('https://localhost:7042/api/pet_image_',Form_Data).subscribe(res =>{console.log(res)});
  }


}
