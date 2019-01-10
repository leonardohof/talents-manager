import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-talents-create-edit',
  templateUrl: './talents-create-edit.component.html',
  styleUrls: ['./talents-create-edit.component.css']
})
export class TalentsCreateEditComponent implements OnInit {

  title: String;
  constructor() { }

  ngOnInit() {
    this.title = 'Create new talent';
  }

}
