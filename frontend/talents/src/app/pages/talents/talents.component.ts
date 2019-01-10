import { Component, OnInit } from '@angular/core';

export interface PeriodicElement {
  name: string;
  email: string;
  position: number;
  weight: number;
  symbol: string;
}

const ELEMENT_DATA: PeriodicElement[] = [
  {position: 1, name: 'Hydrogen', email: 'teste@gmail.com', weight: 1.0079, symbol: 'H'},
  {position: 2, name: 'Helium', email: 'teste@gmail.com', weight: 4.0026, symbol: 'He'},
  {position: 3, name: 'Lithium', email: 'teste@gmail.com', weight: 6.941, symbol: 'Li'},
  {position: 4, name: 'Beryllium', email: 'teste@gmail.com', weight: 9.0122, symbol: 'Be'},
  {position: 5, name: 'Boron', email: 'teste@gmail.com', weight: 10.811, symbol: 'B'},
  {position: 6, name: 'Carbon', email: 'teste@gmail.com', weight: 12.0107, symbol: 'C'},
  {position: 7, name: 'Nitrogen', email: 'teste@gmail.com', weight: 14.0067, symbol: 'N'},
  {position: 8, name: 'Oxygen', email: 'teste@gmail.com', weight: 15.9994, symbol: 'O'},
  {position: 9, name: 'Fluorine', email: 'teste@gmail.com', weight: 18.9984, symbol: 'F'},
  {position: 10, name: 'Neon', email: 'teste@gmail.com', weight: 20.1797, symbol: 'Ne'},
];

@Component({
  selector: 'app-talents',
  templateUrl: './talents.component.html',
  styleUrls: ['./talents.component.css']
})
export class TalentsComponent implements OnInit {

  displayedColumns: string[] = ['name', 'email', 'actions'];
  dataSource = ELEMENT_DATA;

  constructor() { }

  ngOnInit() {
  }

}
