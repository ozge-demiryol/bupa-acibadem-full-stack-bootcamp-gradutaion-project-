import { Component, OnInit } from '@angular/core';
import { faSearch } from '@fortawesome/free-solid-svg-icons';
import { Application } from 'src/app/models/EntityModels/Application';
import { ApplicationService } from 'src/app/services/application.service';

@Component({
  selector: 'app-applications',
  templateUrl: './applications.component.html',
  styleUrls: ['./applications.component.scss']
})
export class ApplicationsComponent implements OnInit {
  applications: Application[] = [];
  searchIcon=faSearch;
  constructor(private _applicationService: ApplicationService,) { }

  ngOnInit(): void {
    this.getApplications();
  }
  getApplications(): void {
    this._applicationService.getApplications().subscribe((res) => {
      this.applications = res.data;
    });
  }
}
