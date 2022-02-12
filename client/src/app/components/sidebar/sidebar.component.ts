import { Component, OnInit } from '@angular/core';
import {faPenToSquare,faUser,faFileText} from '@fortawesome/free-regular-svg-icons';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.scss']
})
export class SidebarComponent implements OnInit {

  userIcon=faUser;
  applyIcon=faPenToSquare;
  policyIcon=faFileText
  constructor() { }

  ngOnInit(): void {
  }

}
