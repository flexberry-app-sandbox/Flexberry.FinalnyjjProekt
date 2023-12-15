import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  id: DS.attr('number'),
  имя: DS.attr('string'),
  номерПас: DS.attr('string'),
  отчество: DS.attr('string'),
  серияПас: DS.attr('string'),
  фамилия: DS.attr('string'),
  должности: DS.belongsTo('i-i-s-finalnyjj-proekt-должности', { inverse: null, async: false }),
  организации: DS.belongsTo('i-i-s-finalnyjj-proekt-организации', { inverse: null, async: false }),
  отделы: DS.belongsTo('i-i-s-finalnyjj-proekt-отделы', { inverse: null, async: false })
});

export let ValidationRules = {
  id: {
    descriptionKey: 'models.i-i-s-finalnyjj-proekt-сотрудники.validations.id.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  имя: {
    descriptionKey: 'models.i-i-s-finalnyjj-proekt-сотрудники.validations.имя.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  номерПас: {
    descriptionKey: 'models.i-i-s-finalnyjj-proekt-сотрудники.validations.номерПас.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  отчество: {
    descriptionKey: 'models.i-i-s-finalnyjj-proekt-сотрудники.validations.отчество.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  серияПас: {
    descriptionKey: 'models.i-i-s-finalnyjj-proekt-сотрудники.validations.серияПас.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  фамилия: {
    descriptionKey: 'models.i-i-s-finalnyjj-proekt-сотрудники.validations.фамилия.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  должности: {
    descriptionKey: 'models.i-i-s-finalnyjj-proekt-сотрудники.validations.должности.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  организации: {
    descriptionKey: 'models.i-i-s-finalnyjj-proekt-сотрудники.validations.организации.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  отделы: {
    descriptionKey: 'models.i-i-s-finalnyjj-proekt-сотрудники.validations.отделы.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('СотрудникиE', 'i-i-s-finalnyjj-proekt-сотрудники', {
    id: attr('Id', { index: 0 }),
    фамилия: attr('Фамилия', { index: 1 }),
    имя: attr('Имя', { index: 2 }),
    отчество: attr('Отчество', { index: 3 }),
    серияПас: attr('Серия паспорта', { index: 4 }),
    номерПас: attr('Номер паспарта', { index: 5 }),
    отделы: belongsTo('i-i-s-finalnyjj-proekt-отделы', 'Отделы', {
      наимнование: attr('Отдел', { index: 7, hidden: true })
    }, { index: 6, displayMemberPath: 'наимнование' }),
    организации: belongsTo('i-i-s-finalnyjj-proekt-организации', 'Организации', {
      наименование: attr('ОрганизациЯ', { index: 9, hidden: true })
    }, { index: 8, displayMemberPath: 'наименование' }),
    должности: belongsTo('i-i-s-finalnyjj-proekt-должности', 'Должности', {
      наименование: attr('Должность', { index: 11, hidden: true })
    }, { index: 10, displayMemberPath: 'наименование' })
  });

  modelClass.defineProjection('СотрудникиL', 'i-i-s-finalnyjj-proekt-сотрудники', {
    id: attr('Id', { index: 0 }),
    фамилия: attr('Фамилия', { index: 1 }),
    имя: attr('Имя', { index: 2 }),
    отчество: attr('Отчество', { index: 3 }),
    серияПас: attr('Серия паспорта', { index: 4 }),
    номерПас: attr('Номер паспорта', { index: 5 }),
    отделы: belongsTo('i-i-s-finalnyjj-proekt-отделы', 'Отдел', {
      наимнование: attr('Отдел', { index: 6 })
    }, { index: -1, hidden: true }),
    организации: belongsTo('i-i-s-finalnyjj-proekt-организации', 'Организация', {
      наименование: attr('Организация', { index: 7 })
    }, { index: -1, hidden: true }),
    должности: belongsTo('i-i-s-finalnyjj-proekt-должности', 'Должность', {
      наименование: attr('Должность', { index: 8 })
    }, { index: -1, hidden: true })
  });
};
