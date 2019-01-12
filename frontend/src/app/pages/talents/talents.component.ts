import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Talent } from 'src/app/models/talent.model';
import { TalentsService } from 'src/app/services/talents.service';
import { DataSource } from '@angular/cdk/table';
import { Observable } from 'rxjs';
import { MatDialogConfig, MatDialog } from '@angular/material';
import { DeleteConfirmDialogComponent } from 'src/app/shared/delete-confirm-dialog/delete-confirm-dialog.component';

@Component({
  selector: 'app-talents',
  templateUrl: './talents.component.html',
  styleUrls: ['./talents.component.css']
})
export class TalentsComponent implements OnInit {

  displayedColumns: string[] = ['name', 'email', 'actions'];
  dataSource = new TalentDataSource(this.talentsService);

  constructor(private router: Router, public dialog: MatDialog, private talentsService: TalentsService) { }

  ngOnInit() {
  }

  addNew() {
    this.router.navigateByUrl('/talents/create');
  }

  edit(id: any) {
    this.router.navigate(['/talents/edit/' + id]);
  }

  delete(id: any) {
    const dialogConfig = new MatDialogConfig();
  
      dialogConfig.disableClose = true;
      dialogConfig.autoFocus = true;
      dialogConfig.data = {
          id: id,
          title: 'Remove talent',
          question: 'Do you really want remove?'
      };
      dialogConfig.width = '500x';
  
      const dialogRef = this.dialog.open(DeleteConfirmDialogComponent, dialogConfig);
  
      dialogRef.afterClosed().subscribe(result => {
        if (result) {
          this.talentsService.deleteTalent(id).subscribe(result => {
            this.dataSource = new TalentDataSource(this.talentsService);
          });
          
        }
      });
  }

}

export class TalentDataSource extends DataSource<any> {
  constructor(private dataService: TalentsService) {
    super();
  }

  connect(): Observable<Talent[]> {
    return this.dataService.getAllTalents();
  }

  disconnect() {
  }
}
