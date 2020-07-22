import { Component, OnInit, NgModule } from '@angular/core';
import { MakeService } from 'src/app/services/make.service';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {
  makes ;
  vehicle = {
    make : ""
  };
  models : any[];
  constructor(private makeService: MakeService) { }

  ngOnInit() {
  this.makeService.getMakes().subscribe(makes =>{
    this.makes = makes;
   });
  
  }
  onMakeChange() {
   var selectedMake =  this.makes.find( m => m.id == this.vehicle.make);
  
  this.models =  selectedMake ? selectedMake.models : [];
  
  }

}
