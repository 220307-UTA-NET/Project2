import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LoginComponent } from './login.component';

describe('LoginComponent', () => {
  let component: LoginComponent;
  let fixture: ComponentFixture<LoginComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LoginComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LoginComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  /*fi(it('should create', () => {
    expect(component).toBeTruthy();
  });*/
  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('çshould have value PET SITTER', () => {
    fixture = TestBed.createComponent(LoginComponent);
    fixture.detectChanges();
    component = fixture.componentInstance;
    expect(component.pet_name).toEqual(' PET SITTER ');
  });

  it('title should be PET SITTER', () => {
    fixture = TestBed.createComponent(LoginComponent);
    fixture.detectChanges();
    component = fixture.componentInstance;
    const comp = fixture.debugElement.nativeElement;
    expect(comp.querySelector('h1').textContent).toContain('PET SITTER');
  });

  it('name text box should be created', () => {
    fixture = TestBed.createComponent(LoginComponent);
    fixture.detectChanges();
    const comp = fixture.debugElement.nativeElement;
    const txtName = comp.querySelector('input[name="name"]')
    expect(txtName).toBeTruthy();
  });





});
