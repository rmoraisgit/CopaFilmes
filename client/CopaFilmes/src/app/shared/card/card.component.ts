import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Subject } from 'rxjs';

@Component({
  selector: 'cf-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.css']
})
export class CardComponent implements OnInit {

  @Input() titulo: string;
  @Input() texto: string;
  @Input() idCheckBox: string;
  @Input() disabled: boolean;
  @Output() onChangeCheckBox = new EventEmitter<boolean>();
  debounce = new Subject<boolean>();

  constructor() { }

  ngOnInit() {
    this.debounce.subscribe(filter => this.onChangeCheckBox.emit(filter));
  }
}
