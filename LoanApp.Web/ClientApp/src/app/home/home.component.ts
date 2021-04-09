import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { finalize } from 'rxjs/internal/operators/finalize';
import { LoanService } from '../services/loan.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit{

  constructor(
    private formBuilder: FormBuilder,
    private loanService: LoanService) { }

    ngOnInit(): void {
        
    }

  loanForm = this.formBuilder.group(
    {
      loanAmount: [
        "",
        [Validators.required, Validators.minLength(3)]
      ],
    });

  onSubmit() {
    console.log(this.loanForm.value);
    this.loanService.register(this.loanForm.value)
      .pipe(finalize(() => {
        //this.spinner.hide();
      }))
      .subscribe(
        result => {
          if (result) {
            //this.alertifyService.success('Registration successful');
          }
        },
        error => {
          //this.alertifyService.error(error);
        });
  }

  get loanAmount() {
    return this.loanForm.get("loanAmount");
  }

  get interestRate() {
    return this.loanForm.get("interestRate");
  }

  get loanPeriod() {
    return this.loanForm.get("loanPeriod");
  }

  get customerName() {
    return this.loanForm.get("customerName");
  }

  get age() {
    return this.loanForm.get("age");
  }

  get nic() {
    return this.loanForm.get("nic");
  }

}
