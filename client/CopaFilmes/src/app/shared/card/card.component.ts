import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'cf-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.css']
})
export class CardComponent implements OnInit {

  @Input() titulo: string;
  @Input() texto: string;
  @Input() idCheckBox: string;

  constructor() { }

  ngOnInit() {
  }
}
