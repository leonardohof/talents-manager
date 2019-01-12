import { Component, OnInit } from "@angular/core";
import {
  FormControl,
  NgForm,
  Validators,
  FormGroup,
  FormGroupDirective,
  FormArray,
  FormBuilder
} from "@angular/forms";
import { ErrorStateMatcher } from "@angular/material/core";
import { TalentsService } from 'src/app/services/talents.service';
import { DataSource } from '@angular/cdk/table';
import { Observable } from 'rxjs';
import { Router, ActivatedRoute } from '@angular/router';
import { Talent } from 'src/app/models/talent.model';

/** Error when invalid control is dirty, touched, or submitted. */
export class MyErrorStateMatcher implements ErrorStateMatcher {
  isErrorState(
    control: FormControl | null,
    form: FormGroupDirective | NgForm | null
  ): boolean {
    const isSubmitted = form && form.submitted;
    return !!(
      control &&
      control.invalid &&
      (control.dirty || control.touched || isSubmitted)
    );
  }
}

@Component({
  selector: "app-talents-create-edit",
  templateUrl: "./talents-create-edit.component.html",
  styleUrls: ["./talents-create-edit.component.css"]
})
export class TalentsCreateEditComponent implements OnInit {  

  id: any;
  title: String;
  skillLevels: any[] = ['0', '1', '2', '3', '4', '5'];
  skillsArr: String[] = [];

  talentForm: FormGroup;

  matcher = new MyErrorStateMatcher();

  saving = false;

  constructor(private router: Router, private route: ActivatedRoute, private fb: FormBuilder, private talentsService: TalentsService) {}

  ngOnInit() {
    this.title = "Create new talent";
    this.talentForm = new FormGroup({
      id: new FormControl('', []),      
      name: new FormControl('', [
        Validators.required,
      ]),
      email: new FormControl('', [
        Validators.required,
        Validators.email,
      ]),
      skype: new FormControl('', [
        Validators.required
      ]),
      linkedin: new FormControl('', [    
      ]),
      phone: new FormControl('', [
        Validators.required
      ]),
      city: new FormControl('', [
        Validators.required
      ]),
      state: new FormControl('', [
        Validators.required
      ]),
      portfolio: new FormControl('', []),
      hourlySalary: new FormControl('', [
        Validators.required,
      ]),
      upToFourHoursPerDay: new FormControl('', []),
      fourToSixHoursPerDay: new FormControl('', []),
      sixToHeightHoursPerDay: new FormControl('', []),
      upToEightHoursPerDay: new FormControl('', []),
      onlyWeekends: new FormControl('', []),
      
      workingMorning: new FormControl('', []),
      workingAfternoon: new FormControl('', []),
      workingNight: new FormControl('', []),
      workingDawn: new FormControl('', []),
      workingBusiness: new FormControl('', []),

      skills: new FormControl('', []),
    });

    this.talentsService.getAllSkills().subscribe(
      result => {        
        this.skillsArr = result;
      }
    )

    this.id = this.route.snapshot.paramMap.get("id");
    if (this.id) {
      this.talentsService.getTalentById(this.id).subscribe(
        result => {
          this.talentForm.patchValue(result);
        }
      );
    }    
  }

  onSubmit() {
    const result: Talent = new Talent(this.talentForm.value);
    result.id = this.id == null ? 0 : this.id;
    // console.log(result);

    if (this.talentForm.valid) {
      this.saving = true;

      if (this.id) {
        this.talentsService.update(this.id, result).subscribe(
          result => {
            // console.log(result);
            this.saving = false;
            this.backToList();
          }
        );
      } else {
        this.talentsService.add(result).subscribe(
          result => {
            // console.log(result);
            this.saving = false;
            this.backToList();
          }
        );
      }      
    }
  }

  backToList() {
    this.router.navigateByUrl("/talents");
  }
}
