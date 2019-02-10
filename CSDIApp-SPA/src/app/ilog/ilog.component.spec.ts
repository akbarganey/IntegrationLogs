/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { IlogComponent } from './ilog.component';

describe('IlogComponent', () => {
  let component: IlogComponent;
  let fixture: ComponentFixture<IlogComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ IlogComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(IlogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
